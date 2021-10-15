#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["crudNetCore/crudNetCore.csproj", "crudNetCore/"]
RUN dotnet restore "crudNetCore/crudNetCore.csproj"
COPY . .
WORKDIR "/src/crudNetCore"
RUN dotnet build "crudNetCore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "crudNetCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "crudNetCore.dll"]
