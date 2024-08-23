using Xunit;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using Windows.System;
using WorkingWithMapsLib.Datastructures;
using System.Xml.Linq;
using Windows.UI.Popups;
using GeoCoordinatePortable;
using WorkingWithMapsLib.Utilities;
using WorkingWithMapsLib.Repository;
using UglyToad.PdfPig.DocumentLayoutAnalysis;

namespace Datasets
{
    public class GenerateDatasets
    {
        HandiSpotRepository repository = new HandiSpotRepository("Credentials/handi-credentials.json");


        [Fact (Skip = "generation of dataset, this is not a test")]
        public void Brussel()
        {
            List<HandiSpot> handiSpots = new List<HandiSpot>();

            // traverse pages in pdf file, and create handi spots
            using (PdfDocument document = PdfDocument.Open("./Brussel/places-de-parking-pmr-recensees-par-bruxelles-mobilite-vbx.pdf"))
            {
                foreach (UglyToad.PdfPig.Content.Page page in document.GetPages())
                {
                    IReadOnlyList<Letter> letters = page.Letters;
                    string example = string.Join(string.Empty, letters.Select(x => x.Value));
                    
                    // for each page, we get all words
                    List<Word> words = page.GetWords().ToList();

                    // we remove all comma's and convert to string
                    List<string> processed_words = words.ConvertAll(x => x.Text.Replace(",", ""));

                    // the first 11 words can be ignored, these are : 
                    // Nombre (taille voiture) - Aantal (grootte auto)
                    int index = processed_words.FindIndex(x => x.StartsWith("auto)"));
                    processed_words.RemoveRange(0, index+1);

                    // size of remaining list must be multiplication of 3
                    Assert.True(processed_words.Count % 3 == 0);

                    for (int i = 0; i < processed_words.Count; i++)
                    {
                        int number = Int32.Parse(processed_words[i]);
                        i = i + 1;
                        double latitude = ConversionHelper.parseToDouble(processed_words[i]);
                        i = i + 1;
                        double longitude = ConversionHelper.parseToDouble(processed_words[i]);

                        HandiSpot hs = new HandiSpot(Guid.NewGuid().ToString(), "", DateTime.Now, new GeoCoordinate(latitude, longitude), number, Paiement.FREE, true, false, "Dataset_Brussel", "");
                        handiSpots.Add(hs);
                    }
                }
            }

            // upload handi spots
            foreach (HandiSpot hs in handiSpots)
            {
                bool succesfulAdd = repository.add(hs).GetAwaiter().GetResult();
                Assert.True(succesfulAdd);
                // respect the rate limit of Google Sheet
                System.Threading.Thread.Sleep(1100);
            }
        }
    }
}
