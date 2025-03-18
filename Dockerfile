# Build Stage (Frontend)
FROM node:20 AS frontend-builder
WORKDIR /app
COPY letsduckinggame.client ./letsduckinggame.client
WORKDIR /app/letsduckinggame.client
RUN npm install && npm run build

# Build Stage (Backend)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS backend-builder
WORKDIR /app
COPY LetsDuckingGame.Server ./LetsDuckingGame.Server
WORKDIR /app/LetsDuckingGame.Server
RUN dotnet restore
RUN dotnet publish -c Release -o /app/published

# Runtime Stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=backend-builder /app/published .
COPY --from=frontend-builder /app/letsduckinggame.client/dist ./wwwroot
EXPOSE 8081
ENTRYPOINT ["dotnet", "LetsDuckingGame.Server.dll"]
