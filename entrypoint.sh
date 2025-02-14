#!/bin/bash
set -e

# Wait for the database to be ready
echo "Waiting for database to be available..."
until dotnet ef database update --project ./redis-docker.csproj; do
  echo "Database is not ready. Retrying in 5 seconds..."
  sleep 5
done

# Start the application
echo "Starting application..."
exec dotnet redis-docker.dll
