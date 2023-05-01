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

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.cliente
    OWNER to postgres;
    
-- Table: public.ciudad

-- DROP TABLE IF EXISTS public.ciudad;

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
    
-- SEQUENCE: public.ciudad_id_seq

-- DROP SEQUENCE IF EXISTS public.ciudad_id_seq;

CREATE SEQUENCE IF NOT EXISTS public.ciudad_id_seq
    INCREMENT 1
    START 1
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 1
    OWNED BY ciudad.id;

ALTER SEQUENCE public.ciudad_id_seq
    OWNER TO postgres;
    
-- SEQUENCE: public.cliente_id_seq

-- DROP SEQUENCE IF EXISTS public.cliente_id_seq;

CREATE SEQUENCE IF NOT EXISTS public.cliente_id_seq
    INCREMENT 1
    START 1
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 1
    OWNED BY cliente.id;

ALTER SEQUENCE public.cliente_id_seq
    OWNER TO postgres;
