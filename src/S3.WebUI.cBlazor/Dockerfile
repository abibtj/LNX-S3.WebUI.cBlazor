FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim
WORKDIR /app
COPY ./bin/Release/netcoreapp3.1 .
ENV ASPNETCORE_URLS http://*:80
ENV ASPNETCORE_ENVIRONMENT docker
EXPOSE 80
EXPOSE 443
ENTRYPOINT dotnet S3.WebUI.cBlazor.dll


#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
#WORKDIR /src
#COPY ["src/S3.WebUI.cBlazor/S3.WebUI.cBlazor.csproj", "src/S3.WebUI.cBlazor/"]
#RUN dotnet restore "src/S3.WebUI.cBlazor/S3.WebUI.cBlazor.csproj"
#COPY . .
#WORKDIR "/src/src/S3.WebUI.cBlazor"
#RUN dotnet build "S3.WebUI.cBlazor.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "S3.WebUI.cBlazor.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "S3.WebUI.cBlazor.dll"]