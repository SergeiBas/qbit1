﻿FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Task4/Task4.csproj", "Task4/"]
RUN dotnet restore "Task4/Task4.csproj"
COPY . .
WORKDIR "/src/Task4"
RUN dotnet build "Task4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task4.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task4.dll"]
