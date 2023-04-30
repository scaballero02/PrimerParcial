-- Table: public.cliente

-- DROP TABLE IF EXISTS public.cliente;

CREATE TABLE IF NOT EXISTS public.cliente
(
    id bigint NOT NULL DEFAULT nextval('cliente_id_seq'::regclass),
    idciudad bigint NOT NULL,
    nombre character varying COLLATE pg_catalog."default",
    apellido character varying COLLATE pg_catalog."default",
    documento character varying COLLATE pg_catalog."default",
    telefono character varying COLLATE pg_catalog."default",
    email character varying COLLATE pg_catalog."default",
    fechanacimiento date,
    ciudad character varying COLLATE pg_catalog."default",
    nacionalidad character varying COLLATE pg_catalog."default",
    CONSTRAINT cliente_pkey PRIMARY KEY (idciudad),
    CONSTRAINT fk_ciudad FOREIGN KEY (idciudad)
        REFERENCES public.ciudad (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

CREATE TABLE IF NOT EXISTS public.ciudad
(
    id bigint NOT NULL DEFAULT nextval('ciudad_id_seq'::regclass),
    ciudad character varying COLLATE pg_catalog."default",
    estado character varying COLLATE pg_catalog."default",
    CONSTRAINT ciudad_pkey PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.ciudad
    OWNER to postgres;
