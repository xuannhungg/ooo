use project_LTWD;
CREATE TABLE ThanhVienSoHoKhau(
	cccd_ChuHo varchar(100) Not Null,
	cccd varchar (100) NOT NULL,
	quanHeVoiChuHo varchar(100) NOT NULL,

	CONSTRAINT pk_thanhVien_soHoKhau
	FOREIGN KEY (cccd_ChuHo)
	REFERENCES SoHoKhau (CMND),

	CONSTRAINT pk_thanhVien_congDan
	FOREIGN KEY (cccd)
	REFERENCES CongDan (cmnd),
);

insert into ThanhVienSoHoKhau(cccd_ChuHo, cccd, quanHeVoiChuHo)
values ('1800456','666','Con trai');
insert into ThanhVienSoHoKhau(cccd_ChuHo, cccd, quanHeVoiChuHo)
values ('1800457','1800458','Con trai');

insert into ThanhVienSoHoKhau(cccd_ChuHo, cccd, quanHeVoiChuHo)
values ('1800457','1','Con gai');

select * from ThanhVienSoHoKhau

select shk.hoTenChuHo, shk.CMND as cmnd_chuHo, cd.cmnd as cmnd_thanhVien, cd.hoTen as hoTen_ThanhVien, tv.quanHeVoiChuHo
from CongDan cd, SoHoKhau shk, ThanhVienSoHoKhau tv
where cd.cmnd = shk.CMND and shk.CMND = tv.cccd_ChuHo 

