#!/bin/bash

cd LoveHistoryWebApp

# Send request to download LoveInfo.json
curl -o wwwroot/LoveInfo.json https://test-dotnet-my-webapp.azurewebsites.net/LoveInfo.json

# Build project in release mode
dotnet build --configuration Release

# Publish project in release mode
dotnet publish --configuration Release

# Execute deploy to Azure command
az webapp up --sku F1 --name test-dotnet-my-webapp --resource-group test-rg
