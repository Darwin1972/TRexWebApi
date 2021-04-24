#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TRexWebApi.csproj", "."]
RUN dotnet restore "./TRexWebApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "TRexWebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TRexWebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY ./https/aspnetapp.pfx /https/aspnetapp.pfx
ENTRYPOINT ["dotnet", "TRexWebApi.dll"]