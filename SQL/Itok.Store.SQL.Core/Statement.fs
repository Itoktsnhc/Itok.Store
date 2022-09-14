module Itok.Store.SQL.Core

type DDLStatement =
    |Create
    |Drop

type DMLStatement =
    |Insert
    |Select
    |Delete
    |Update

type CustomStatement =
    |Quit
    |ExecFile
    |Show

type Statement =
    |DDL of DDLStatement
    |DML of DMLStatement
    |Custom of CustomStatement
