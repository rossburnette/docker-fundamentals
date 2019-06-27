# Build stage
FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base

WORKDIR /app

# restore
FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src

COPY Initial.Api/Initial.Api.csproj ./Initial.Api/
RUN dotnet restore Initial.Api/Initial.Api.csproj

COPY Initial.Api.Tests/Initial.Api.Tests.csproj ./Initial.Api.Tests
RUN dotnet restore Initial.Api.Tests/Initial.Api.Tests.csproj

RUN ls -alR

# copy src

# tests

# publish

# Runtime stage