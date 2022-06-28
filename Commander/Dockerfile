# Get base SDK image from Microsoft (Full .NET Core SDK), Create working directory (this is where app will reside)
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy the .csproj file (contains dependencies, specifies how code runs) and restore
COPY ["Commander.csproj", "./"]
RUN dotnet restore

# Copy project files and build release, out is the folder containing app build dll
COPY . ./
RUN dotnet publish -c Release -o out

# Generate runtime image; aspnet runtime image is the only one necessary, so it is the only one retrieved
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
EXPOSE 80
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "Commander.dll"]