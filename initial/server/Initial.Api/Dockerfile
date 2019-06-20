FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY Initial.Api/Initial.Api.csproj Initial.Api/
RUN dotnet restore Initial.Api/Initial.Api.csproj
COPY . .
WORKDIR /src/Initial.Api
RUN dotnet build Initial.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Initial.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Initial.Api.dll"]
