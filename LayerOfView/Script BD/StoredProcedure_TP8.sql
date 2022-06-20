/****** Object:  StoredProcedure [dbo].[spAddBranch]    Script Date: 07/06/2022 19:44:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAddBranch](
	@NombreSucursal VARCHAR(100),
	@DescripcionSucursal VARCHAR(100),
	@Id_ProvinciaSucursal INT,
	@DireccionSucursal VARCHAR(100)
) AS INSERT INTO Sucursal(NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal) VALUES(@NombreSucursal, @DescripcionSucursal, @Id_ProvinciaSucursal, @DireccionSucursal);
GO
/****** Object:  StoredProcedure [dbo].[spDelete]    Script Date: 07/06/2022 19:44:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDelete](
	@Id_Sucursal INT
) AS DELETE Sucursal WHERE Id_Sucursal = @Id_Sucursal;
GO
