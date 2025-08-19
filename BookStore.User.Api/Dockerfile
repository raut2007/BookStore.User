# Base image for runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Build and publish app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the full project files
COPY . .

# Restore and publish
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

# Final image for runtime
FROM base AS final
WORKDIR /app

# Copy published files to runtime image
COPY --from=build /app/publish .

# Set Kestrel to listen on port 80 inside container
ENV ASPNETCORE_URLS=http://+:80

# IMPORTANT: Use your actual DLL name here
ENTRYPOINT ["dotnet", "BookStore.User.Api.dll"]
