FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base

LABEL author="Jordan Jordanov"

ENV DOTNET_USE_POLLING_FILE_WATCHER=1
ENV ASPNETCORE_URLS=http://*:5000

WORKDIR /app
CMD ["/bin/bash", "-c", "dotnet restore && dotnet run"]