FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS Base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS Build
WORKDIR /src
COPY *.sln ./
COPY ["APIs/WebAPI/WebAPI.csproj", "APIs/WebAPI/"]
COPY ["APIs/Infracstructures/Infracstructures.csproj", "APIs/Infracstructures/"]
COPY ["APIs/Domain/Domain.csproj", "APIs/Domain/"]
COPY ["APIs/Application/Application.csproj", "APIs/Application/"]

COPY ["Tests/WebAPI.Tests/WebAPI.Tests.csproj", "Tests/WebAPI.Tests/"]
COPY ["Tests/Infrastructures.Tests/Infrastructures.Tests.csproj", "Tests/Infrastructures.Tests/"]
COPY ["Tests/Domain.Tests/Domain.Tests.csproj", "Tests/Domain.Tests/"]
COPY ["Tests/Applications.Tests/Applications.Tests.csproj", "Tests/Applications.Tests/"]
RUN dotnet restore 

# Sao chép tất cả các file và xây dựng ứng dụng
COPY . .
WORKDIR "/src/APIs/WebAPI"
RUN dotnet build "WebAPI.csproj" -c Release -o /app/build

# Bước publish ứng dụng
FROM build AS publish
RUN dotnet publish "WebAPI.csproj" -c Release -o /app/publish

# Bước chạy ứng dụng
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebAPI.dll"]
