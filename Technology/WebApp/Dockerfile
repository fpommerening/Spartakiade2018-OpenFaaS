FROM microsoft/dotnet:2.0-sdk AS builder

WORKDIR /app
COPY src /app
RUN dotnet restore WebApp.csproj
RUN dotnet publish --configuration Release --output ./out


FROM microsoft/aspnetcore:2.0
LABEL maintainer "frank@pommerening-online.de"
ENV REFRESHED_AT 2017-10-30

ENV ASPNETCORE_URLS http://0.0.0.0:8080
EXPOSE 8080

WORKDIR /app/
COPY --from=builder /app/out/* ./

ENTRYPOINT ["dotnet", "WebApp.dll"]