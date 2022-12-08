FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AdventOfCode.DayOne/AdventOfCode.DayOne.csproj", "AdventOfCode.DayOne/"]
RUN dotnet restore "AdventOfCode.DayOne/AdventOfCode.DayOne.csproj"
COPY . .
WORKDIR "/src/AdventOfCode.DayOne"
RUN dotnet build "AdventOfCode.DayOne.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AdventOfCode.DayOne.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdventOfCode.DayOne.dll"]
