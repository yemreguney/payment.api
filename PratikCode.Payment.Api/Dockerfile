FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PratikCode.Payment.Api/PratikCode.Payment.Api.csproj", "PratikCode.Payment.Api/"]
RUN dotnet restore "PratikCode.Payment.Api/PratikCode.Payment.Api.csproj"
COPY . .
WORKDIR "/src/PratikCode.Payment.Api"
RUN dotnet build "PratikCode.Payment.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PratikCode.Payment.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PratikCode.Payment.Api.dll"]
