#!/bin/bash

cd LoveHistoryWebApp

# Send request to download LoveInfo.json
curl -o wwwroot/LoveInfo.json https://test-dotnet-my-webapp.azurewebsites.net/LoveInfo.json

# Build project in release mode
dotnet build --configuration Release

# Publish project in release mode
dotnet publish --configuration Release

cd bin/Release/net7.0/publish

# Execute deploy to Azure command
az webapp up --name test-dotnet-my-webapp --resource-group test-rg --runtime "DOTNET|8"
