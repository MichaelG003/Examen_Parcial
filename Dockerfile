
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80


FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["appRemesas/appRemesas.csproj", "appRemesas/"]
RUN dotnet restore "appRemesas/appRemesas.csproj"
COPY . .
WORKDIR "/src/appRemesas"
RUN dotnet build "appRemesas.csproj" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "appRemesas.csproj" -c Release -o /app/publish


FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "appRemesas.dll"]