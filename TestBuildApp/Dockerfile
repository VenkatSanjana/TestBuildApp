#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src

#COPY ["TestBuildApp.csproj", "TestBuildApp/"]
COPY . TestBuildApp/
RUN dotnet restore "TestBuildApp/TestBuildApp.csproj"
COPY . .
WORKDIR "/src/TestBuildApp"
RUN dotnet build "TestBuildApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestBuildApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestBuildApp.dll"]