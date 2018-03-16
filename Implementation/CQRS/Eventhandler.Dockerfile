FROM microsoft/dotnet:2.0-sdk AS builder

WORKDIR /app
COPY Common /Common
COPY EventHandler /app
RUN dotnet restore EventHandler.csproj
RUN dotnet publish --configuration Release --output ./out


FROM microsoft/dotnet:2.0-runtime
LABEL maintainer "frank@pommerening-online.de"
ENV REFRESHED_AT 2018-03-13

WORKDIR /app/
COPY --from=builder /app/out/* ./

ENTRYPOINT ["dotnet", "EventHandler.dll"]