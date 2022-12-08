FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AdventOfCode.DayTwo/AdventOfCode.DayTwo.csproj", "AdventOfCode.DayTwo/"]
RUN dotnet restore "AdventOfCode.DayTwo/AdventOfCode.DayTwo.csproj"
COPY . .
WORKDIR "/src/AdventOfCode.DayTwo"
RUN dotnet build "AdventOfCode.DayTwo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AdventOfCode.DayTwo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdventOfCode.DayTwo.dll"]
