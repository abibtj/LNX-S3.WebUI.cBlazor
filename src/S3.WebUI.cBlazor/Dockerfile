# FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
# WORKDIR /src
# COPY S3.WebUI.cBlazor.csproj .
# RUN dotnet restore "S3.WebUI.cBlazor.csproj"
# COPY . .
# RUN dotnet build "S3.WebUI.cBlazor.csproj" -c Release -o /app/build

# FROM build AS publish
# RUN dotnet publish "S3.WebUI.cBlazor.csproj" -c Release -o /app/publish

# FROM nginx:alpine AS final
# WORKDIR /usr/share/nginx/html
# COPY --from=publish /app/publish/S3.WebUI.cBlazor/dist .
# COPY nginx.conf /etc/nginx/nginx.conf


##################################################
#FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
FROM nginx:alpine AS final
ENV ASPNETCORE_ENVIRONMENT docker

#Remove default configuration
RUN rm /etc/nginx/conf.d/default.conf 

WORKDIR /usr/share/nginx/html
COPY ./bin/Debug/netstandard2.1/dist .
COPY nginx.conf /etc/nginx/nginx.conf
VOLUME /usr/share/nginx/html
VOLUME /etc/nginx


##########################################################
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