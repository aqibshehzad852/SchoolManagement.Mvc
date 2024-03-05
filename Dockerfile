# Use the official Microsoft SQL Server image
FROM mcr.microsoft.com/mssql/server

# Set the environment variables for SQL Server
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=aqib123

# Expose the port used by SQL Server
EXPOSE 1433

# Start SQL Server on container launch
CMD /opt/mssql/bin/sqlservr
