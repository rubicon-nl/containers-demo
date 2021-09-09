# syntax=docker/dockerfile:1 
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build 
WORKDIR /source 
 
# Copy source, restore and build 
COPY . . 
RUN dotnet restore 
RUN dotnet publish -c release -o /app --no-restore 
 
# Run image from aspnet container 
FROM mcr.microsoft.com/dotnet/aspnet:5.0 
WORKDIR /app 
COPY --from=build /app ./ 
EXPOSE 80/tcp 
ENTRYPOINT ["dotnet", "app.dll"] 