#!/bin/sh
# see https://www.baeldung.com/spring-boot-rest-client-swagger-codegen
# see https://medium.com/@no0law1/generate-client-sdk-for-net-core-using-open-api-no0law1-4767fa86a17f

# 1. download openapi-generator-cli.jar

FILE=./openapi-generator-cli.jar
if [ -f "$FILE" ]; then
    echo "$FILE already downloaded."
else 
    echo "$FILE does not exist, start downloading ..."
    # Tried version 7.2.0, but with the version bump of RestSharp, there are dependencies requiring System.Text.Json 7.x, while it seems we have something
    # expecting 6.0.0.5. Might be related to our Config.Net, as it appears with the PersistentUserStore. It is at least the same reason we cannot bump
    # our Sentry.
    # Tried some resolution strategies by having direct dependency and use Assembly Binding Redirects, but I don't understand it enough to use it effectively. 
    # So did not find a solution in a reasonable time. Not aided by the fact that with .NET Framework 4.8 we are still on a 'legacy' resolution scheme, which
    # has been replaced by a more sophisticated one in .NET 5/Core.
	curl https://repo1.maven.org/maven2/org/openapitools/openapi-generator-cli/6.6.0/openapi-generator-cli-6.6.0.jar --output ./openapi-generator-cli.jar 
fi

echo "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"
echo "!do not forget to upgrade the version of openapi-generator within this script once in a while!"
echo "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"

read -p "Press [Enter] key to continue..."

# 2. generate SDK

generateSDK () {
	echo "generating SDK based on : "
    echo $1
	java -jar openapi-generator-cli.jar generate -i $1 -g csharp-netcore -o BlueSpot.Client.Sdk --additional-properties packageName=BlueSpot.Client.Sdk
} 

echo "Based on which definition do you want to generate?"
echo ""
echo " localsystem --> [NOT SUPPORTED YET] only works if swagger doc has been generated locally"
echo ""
echo " localhost --> [NOT SUPPORTED YET] only works if server is running locally"	
echo ""
echo " remote --> only works if remote server (on Render) is running"
echo ""	
select server in "localsystem" "localhost" "remote"; do
    case $server in
		localsystem ) generateSDK "../todo/openapi.json" & break;;
        localhost ) generateSDK "http://localhost:todo/todo/v3/api-docs" & break;;
		remote ) generateSDK "https://bluespotserver.onrender.com/v3/api-docs" & break;;
    esac
done
  
read -p "Press [Enter] key to continue..."

