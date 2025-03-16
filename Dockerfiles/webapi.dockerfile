# Use .NET 8 SDK image for development
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS dev

# Set working directory inside the container
WORKDIR /app

# Copy only the project file(s) to leverage Docker cache
COPY ["./WebAPI/*.csproj", "./"]
RUN dotnet restore

# Copy the rest of the application files
COPY ["./WebAPI/.", "./"]

# Expose the Blazor Server port
EXPOSE 8080

# Set the entrypoint to run in watch mode
ENTRYPOINT ["dotnet", "watch"]