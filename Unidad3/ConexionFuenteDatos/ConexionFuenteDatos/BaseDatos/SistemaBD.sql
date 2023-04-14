CREATE TABLE IF NOT EXISTS Entidad 
(
    EntidadID INTEGER PRIMARY KEY AUTOINCREMENT,
    Tipo TEXT,
    Nombre TEXT,
    Apellido TEXT,
    Telefono TEXT,
    Email TEXT,
    DireccionFacturacion TEXT,
    DireccionEnvio TEXT,
    Credito BOOLEAN,
    LimiteCredito REAL,
    UsuarioID INTEGER,
    FechaCreacion TEXT,
    FechaActualizacion TEXT
);

CREATE TABLE IF NOT EXISTS Usuario 
(
    UsuarioID INTEGER PRIMARY KEY AUTOINCREMENT,
    Tipo TEXT,
    Nombre TEXT,
    Apellido TEXT,
    Email TEXT,
    NombreUsuario TEXT,
    ClaveUsuario TEXT,
    Activo BOOLEAN
);

INSERT INTO Usuario 
(Tipo, Nombre, Apellido, Email, NombreUsuario, ClaveUsuario, Activo) 
VALUES ('Superusuario', 'Administrador', 'Sistema', 'admin@sistema.com', 'admin', 'admin', 1);