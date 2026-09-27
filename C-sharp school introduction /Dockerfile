FROM mcr.microsoft.com/dotnet/runtime:10.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["C-sharp school introduction /C-sharp school introduction.csproj", "C-sharp school introduction /"]
RUN dotnet restore "C-sharp school introduction /C-sharp school introduction.csproj"
COPY . .
WORKDIR "/src/C-sharp school introduction "
RUN dotnet build "./C-sharp school introduction.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./C-sharp school introduction.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "C-sharp school introduction.dll"]
