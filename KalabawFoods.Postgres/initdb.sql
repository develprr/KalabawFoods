
CREATE USER kalabaw WITH ENCRYPTED PASSWORD 'kalabaw';
SELECT 'CREATE DATABASE kalabawfoods' WHERE NOT EXISTS (SELECT FROM pg_database WHERE datname = 'kalabawfoods')\gexec
ALTER DATABASE kalabawfoods OWNER TO kalabaw;