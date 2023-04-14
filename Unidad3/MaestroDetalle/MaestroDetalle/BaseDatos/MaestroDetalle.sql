CREATE TABLE IF NOT EXISTS OrdenVenta 
(
    OrdenID INTEGER PRIMARY KEY AUTOINCREMENT,
    NumeroOrden TEXT,
    FechaOrden DATE,
    TotalOrden REAL,
    NombreCliente TEXT,
    Contacto TEXT,
    FechaEntrega DATE,
    DireccionEnvio TEXT,
    FechaCreacion TEXT,
    FechaActualizacion TEXT
);

CREATE TABLE IF NOT EXISTS OrdenVentaDetalle 
(
    OrdenDetalleID INTEGER PRIMARY KEY AUTOINCREMENT,
    OrdenID INTEGER,
    Articulo TEXT,
    Cantidad REAL,
    PrecioUnitario REAL,
    PrecioTotal REAL,
    FechaCreacion TEXT,
    FechaActualizacion TEXT
);