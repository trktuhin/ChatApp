FROM mcr.microsoft.com/mssql/server:2022-latest

# Switch to root user to modify permissions
USER root

# Change ownership
RUN chown -R 10001:0 /var/opt/mssql && chmod -R 775 /var/opt/mssql

# Switch back to SQL Server user for security
USER 10001

ENTRYPOINT ["/opt/mssql/bin/sqlservr"]