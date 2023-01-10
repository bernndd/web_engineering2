FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 9000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
RUN dir
COPY ["/src/Org.OpenAPITools/personal.csproj", "personal/"]
RUN dotnet restore "/src/Org.OpenAPITools/personal.csproj"
COPY . .
WORKDIR "/src/Org.OpenAPITools"
RUN dotnet build "personal.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "personal.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "personal.dll"]
