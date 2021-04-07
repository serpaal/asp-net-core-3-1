FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /project

COPY ["net-core/MesaAyuda.API/MesaAyuda.API.csproj", "net-core/MesaAyuda.API/"] 
COPY . .

WORKDIR "/project/net-core/MesaAyuda.API"
RUN dotnet build "MesaAyuda.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MesaAyuda.API.csproj" -c Release -o /app/publish

FROM base AS final
RUN apt-get update
RUN apt-get install -y unixodbc-dev
ADD odbc.ini /etc/odbcinst.ini
ADD odbcinst.ini /etc/odbcinst.ini


WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MesaAyuda.API.dll"]