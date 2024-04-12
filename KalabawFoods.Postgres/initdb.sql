CREATE USER kalabaw WITH ENCRYPTED PASSWORD 'kalabaw';
CREATE DATABASE kalabawfoods;
ALTER DATABASE kalabawfoods OWNER TO kalabaw;
GRANT ALL PRIVILEGES ON DATABASE kalabawfoods TO kalabaw