FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["meth5/meth5.csproj", "meth5/"]
RUN dotnet restore "meth5/meth5.csproj"
COPY . .
WORKDIR "/src/meth5"
RUN dotnet build "meth5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "meth5.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "meth5.dll"]
