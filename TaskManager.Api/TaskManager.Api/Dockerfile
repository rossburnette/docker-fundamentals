FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY TaskManager.Api/TaskManager.Api.csproj TaskManager.Api/
RUN dotnet restore TaskManager.Api/TaskManager.Api.csproj
COPY . .
WORKDIR /src/TaskManager.Api
RUN dotnet build TaskManager.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish TaskManager.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TaskManager.Api.dll"]
