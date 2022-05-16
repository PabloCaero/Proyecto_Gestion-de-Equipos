Use Equipos_Nuevos

Select E.ID, E.Ticket, E.IDTecnicoAsignado, T.Legajo, T.Apellidos, T.Nombres,  E.IDOficina, O.Nombre as Oficina, E.Nombre, E.Tipo, E.IDCPU, CP.Descripcion as CPU, E.IDGPU, GP.Descripcion as GPU, 
E.IDRAM, R.Descripcion as RAM, E.IDDISCO1, DIS.Descripcion as Disco1, E.IDDISCO2, DIS.Descripcion as Disco2, E.IDWIN, LW.Numero as LicenciaWindows, E.IDOFFICE, LO.Numero as LicenciaOffice, LCO.Descripcion as Cuenta 
From Equipos E
Inner Join LicenciasOffice LO ON E.IDOFFICE = LO.ID
Inner Join LicenciasCartonOffice LCO ON LO.IDCartonOffice = LCO.ID
Inner Join Cuentas C ON C.ID = LCO.IDCuenta
Inner Join RAMs R ON R.ID = E.IDRAM
Inner Join LicenciasWindows LW ON LW.ID = E.IDWIN
Inner Join Oficinas O ON O.ID = E.IDOficina
Inner Join CPUs CP ON CP.ID = E.IDCPU
Inner Join GPUs GP ON GP.ID = E.IDGPU
Inner Join DISCOs DIS ON DIS.ID = E.IDDISCO1 and DIS.ID = E.IDDISCO2
Inner Join Tecnicos T ON T.ID = E.IDTecnicoAsignado

Select * From Equipos
 