SET DATEFORMAT DMY 
-- TẠO BẢNG KHOA 
INSERT INTO KHOA (MAK , TENK , MATRUONGKHOA )
VALUES 
('KH0001',N'KHOA NỘI',NULL),
('KH0002',N'KHOA NGOẠI',NULL),
('KH0003',N'KHOA NỘI TIM MẠCH',NULL),
('KH0004',N'KHOA NỘI TIÊU HÓA',NULL),
('KH0005',N'KHOA PHỤ SẢN',NULL)
SELECT*FROM KHOA
GO 
-- TẠO BẢNG NHÂN VIÊN 
INSERT INTO NHANVIEN (MANV , HONV ,  TENNV , DIACHI , NGAYSINH , PHAI , CHUCVU , VAITRO, NGAYLV,MAKHOA )
VALUES
  ('NV0001',N'Phạm Đình ',N'Trung',N'48 Bùi Viện ,Q1 ,TP.HCM','8/9/1990',N'NAM',N'Bảo Vệ',N'Nhân Viên','22/4/2014','KH0001'),
('NV0002',N'Phan Mai',N'Phương',N'54 Bạch Đằng ,Phú Nhuận ,TP.HCM','29/6/1990',N'NỮ',N'Tạp Vụ',N'Nhân Viên','30/5/2016','KH0002'),
('NV0003',N'Lê Anh ',N'Dũng',N'54 Bạch Đằng ,Phú Nhuận ,TP.HCM','19/12/1990',N'NAM',N'Bảo Vệ',N'Nhân Viên','22/4/2017','KH0003'),
('NV0004',N'Nguyễn Hữu ',N'Đạt',N'48 Bùi Viện ,Q1 ,TP.HCM','28/4/1990',N'NAM',N'Điều Dưỡng',N'Nhân Viên','22/4/2017','KH0001'),
('NV0005',N'Trương Đặng Ngọc',N'Cầm',N'468 Mã Lò ,Bình Tân ,TP.HCM','25/6/1991',N'NỮ',N'Điều Dưỡng',N'Nhân Viên','22/4/2018','KH0002'),
('NV0006',N'Phạmh Minh ',N'Anh',N'49 Trần Quang Khải ,Q1 ,TP.HCM','10/4/1993',N'NAM',N'Điều Dưỡng',N'Nhân Viên','2/7/2019','KH0003'),
('NV0007',N'Nguyễn Tiến ',N'Đạt',N'46 ,Bình Tân ,TP.HCM','22/2/1994',N'NAM',N'Điều Dưỡng',N'Nhân Viên','22/4/2019','KH0004'),
('NV0008',N'Hoàng Minh ',N'Anh',N'468 Mã Lò ,Bình Tân ,TP.HCM','29/11/1998',N'NAM',N'Bảo Vệ',N'Nhân Viên','22/4/2020','KH0004'),
('NV0009',N'Phạm Ngọc',N'Nhi',N'46 ,Bình Tân ,TP.HCM','15/5/1996',N'NỮ',N'Điều Dưỡng',N'Nhân Viên','8/1/2021','KH0005'),
('NV00010',N'Phạm Thị Minh',N'Anh',N'486 Phan Xích Long,Phú Nhuận,TP.HCM','1/5/1998',N'NỮ',N'Thu Ngân',N'Nhân Viên','25/1/2021','KH0005'),
('BS00011',N'Nguyễn Công ',N'Toàn',N'50 Bùi Viện ,Q1 ,TP.HCM','20/9/1990',N'Nam',N'Bác Sĩ Hạng 1',N'Bác Sĩ','22/4/2014','KH0002'),
('BS00012',N'Trần Đình ',N'Thành ',N'49 ,Bình Tân ,TP.HCM','15/9/1996',N'Nam',N'Thực Tập ',N'Bác Sĩ','22/1/2020','KH0002'),
('BS00013',N'Lê Thị Kim  ',N'Ngân',N'456 Phan Xích Long,Phú Nhuận,TP.HCM','1/5/1991',N'NỮ',N'Bác Sĩ Hạng 2 ',N'Bác Sĩ','15/4/2014','KH0001'),
('BS00014',N'Nguyễn Đức ',N'Hạnh',N'60 Bạch Đằng ,Phú Nhuận ,TP.HCM','10/1/1989',N'Nam',N'Bác Sĩ Hạng 1',N'Bác Sĩ','1/9/2013','KH0001'),
('BS00015',N'Nguyễn Viết ',N'Minh',N'469 Mã Lò ,Bình Tân ,TP.HCM','26/6/1992',N'Nam',N'Bác Sĩ Hạng 3',N'Bác Sĩ','1/2/2016','KH0005'),
('BS00016',N'Nguyễn Công ',N'Toàn',N'50 Bùi Viện ,Q1 ,TP.HCM','2/2/1992',N'Nam',N'Bác Sĩ Hạng 3 ',N'Bác Sĩ','12/3/2015','KH0003'),
('BS00017',N'Lê Minh ',N'Triết',N'20 Trần Quang Khải ,Q1 ,TP.HCM','15/9/1996',N'Nam',N'THỰC TẬP',N'Bác Sĩ','10/2/2020','KH0004'),
('BS00018',N'Phạm Văn ',N'Khương',N'4 ,Bình Tân ,TP.HCM','10/5/1990',N'Nam',N'Bác Sĩ Hạng 1',N'Bác Sĩ','5/4/2013','KH0005'),
('BS00019',N'Nguyễn Tú ',N'Uyên',N'9 Trần Quang Khải ,Q1 ,TP.HCM','1/8/1990',N'NỮ',N'Bác Sĩ Hạng 1 ',N'Bác Sĩ','20/10/2013','KH0003'),
('BS00020',N'Đinh Công ',N'Thành',N'10 ,Bình Tân ,TP.HCM','30/10/1990',N'Nam',N'Bác Sĩ Hạng 1',N'Bác Sĩ','23/7/2013','KH0004')
 SELECT*FROM NHANVIEN
GO

-- TẠO BẢNG BỆNH NHÂN 
INSERT INTO BENHNHAN ( MABN , HOBN , TENBN , SODTH ,DIACHI, NGAYSINH , PHAI , MABHYT )
VALUES 
('BN0001',N'NGUYỄN THỊ KIỀU ',N'TRANG','09876543212',N'47 NGUYỄN HUỆ,Q1,TP.HCM','21/06/1980',N'NỮ',null),
('BN0002',N'LÊ BÁ ',N'TRÍ','02334567891',N'145 ĐỒNG KHỞI ,Q1,TP.HCM','26/04/1985',N'NAM',null),
('BN0003',N'TRẦN THỊ',N'MƯỜI','09877513212',N'45 HAI BÀ TRƯNG,Q3,TP.HCM','5/12/1988',N'NỮ','HS7030120228897'),
('BN0004',N'TRẦN THANH',N'TÙNG','04512947382',N'36 NGUYỄN THỊ MINH KHAI,Q BÌNH HẠNH,TP.HCM','15/06/1990',N'NAM',null),
('BN0005',N'NGUYỄN NGỌC ',N'THỦY','09813487624',N'HAI BÀ TRƯNG,Q4,TP.HCM','3/12/1988',N'NỮ',null),
('BN0006',N'TRÂN THANH',N'TOÀN','01873513212',N'24 ĐỒNG KHỞI ,Q1,TP.HCM','12/1/1986',N'NAM',null),
('BN0007',N'TÔ NHẬT',N'QUANG','01512942389',N'67 TRẦN HƯNG ĐẠO,Q5,TP.HCM','21/4/1999',N'NAM','HS5012330879870'),
('BN0008',N'NGUYỄN ÁNH',N'NGUYỆT','09334867899',N'125 TRẦN HƯNG ĐẠO ,Q1,TP.HCM','1/1/1980',N'NỮ',null),
('BN0009',N' NGUYỄN THANH ',N'THỦY','09776543211',N'324 NGUYỄN THỊ MINH KHAI ,Q BÌNH HẠNH ,TP.HCM','2/10/2000',N'NỮ',null),
('BN00010',N'LÊ NGỌC MINH',N'ĐẮC','0813994098',N'24 KỲ ĐÔNG ,Q3,TP.HCM','21/06/2005',N'NAM', 'HS4010120878817')
 SELECT*FROM BENHNHAN
GO
-- TẠO BẢNG THUỐC 
INSERT INTO THUOC (MATHUOC, TENTHUOC,GIA)
 VALUES ('TH001',N'Viên ngậm Cufo vị mật ong chanh hỗ trợ điều trị triệu chứng trong nhiễm khuẩn miệng và họng','1.600'),
('TH002',N'Thuốc Tocemux điều trị tiêu chất nhầy, bệnh lý hô hấp có đờm ','700'),
('TH003',N'Siro HoAstex OPC điều trị ho, giảm ho trong viêm họng, viêm phế quản (90ml)','38.000'),
('TH004',N'Thuốc Euxamus 200mg Euvipharm tiêu chất nhầy trong bệnh nhầy nhớt ','800'),
('TH005',N'Thuốc Medi-Ambroxol Medisun tiêu chất nhầy đường hô hấp ','6.000'),
('TH006',N'Tinh dầu trẻ em Nasomom-4 Reliv giảm triệu chứng nghẹt mũi, sổ mũi, khò khè, cảm cúm (70ml) ','39.000'),
('TH007',N'Thuốc Dacolfort Danapha điều trị triệu chứng liên quan đến suy tĩnh mạch, mạch bạch huyết ','2.600'),
('TH008',N'Siro Deslotid OPV trị viêm mũi dị ứng, phản ứng dị ứng da (60ml) ','65.000'),
('TH009',N'Thuốc Exopadin 60mg Trường Thọ điều trị viêm mũi dị ứng, mày đay ','2.000'),
('TH0010',N'Thuốc nhỏ mắt V.Rohto Vitamin hỗ trợ cải thiện tình trạng giảm thị lực, mắt mờ (13ml) ','51.990'),
('TH0011',N'Thuốc nhỏ mắt Eyemiru 40 EX điều trị căng mắt, xung huyết kết mạc (15ml) ','73.800'),
('TH0012',N'Thuốc nhỏ mắt, nhỏ mũi Natri Clorid 0,9% Pharmedic (10ml) ','3.000'),
('TH0013',N'Thuốc nhỏ mắt Rohto Antibacterial điều trị lẹo mắt, viêm kết mạc, viêm mi mắt (13ml) ','53.000'),
('TH0014',N'Thuốc Myhemo BRV điều trị dự phòng thiếu sắt và folic acid trong khi mang thai','5.500'),
('TH0015',N'Dung dịch uống CalciMAX OPV giúp ngon miệng, chắc khỏe xương ','7.500'),
('TH0016',N'Thuốc Magnesium - B6 TV.Pharm giảm các triệu chứng thiếu hụt magnesi, nôn mửa, khó chịu ','500'),
('TH0017',N'Viên ngậm sát trùng Tyrotab Pharmedic điều trị viêm họng, viêm amidan ','500'),
('TH0018',N'Kem bôi da Ketoconazol 2% Medipharco điều trị các bệnh nấm da và niêm mạc (10g) ','11.000'),
('TH0019',N'Kem bôi da Lifedovate Cream 0,05% Hadiphar điều trị các vết long eczema, viêm da (10g) ','35.000'),
('TH0020',N'Thuốc Warfarin 5 S.P.M điều trị ngắn hạn huyết khối tĩnh mạch và nghẽn mạch phổi cấp tính ','7.334'),
('TH0021',N'Viên nén Metformin 850mg Tipharco điều trị đái tháo đường  ','300'),
('TH0022',N'Thuốc Stadovas 5 CAP Stella điều trị tăng huyết áp, đau thắt ngực mạn tính ổn định ','200'),
('TH0023',N'Thuốc Berberin 100mg Domesco điều trị nhiễm khuẩn đường ruột, tiêu chảy, kiết lỵ  ','650'),
('TH0024',N'Dung dịch Suncurmin Sao Thái Dương điều trị viêm loét dạ dày, hành tá tràng (100ml)  ','50.000'),
('TH0025',N'Viên uống Jex Natural Ecogreen hỗ trợ giảm đau trong thoái hoá khớp, viêm khớp  ','11.000'),
('TH0026',N'Hỗn dịch uống Phosphalugel Sanofi giảm độ axit của dạ dày ','4.200')
  SELECT*FROM THUOC 
 GO

-- TẠO BẢNG HÓA ĐƠN
INSERT INTO HOADON(MAHD, MABN, NGAYLAP, THANHTIEN)
VALUES
('HD0001',  'BN0001','3/9/2023', NULL),
('HD0002',  'BN0002','2/4/2023', NULL),
('HD0003', 'BN0003','12/6/2023', NULL),
('HD0004', 'BN0004', '4/9/2023', NULL),
('HD0005', 'BN0005','3/9/2023', NULL),
('HD0006', 'BN0006','3/1/2023', NULL),
('HD0007', 'BN0007','21/12/2023',NULL),
('HD0008', 'BN0008','8/4/2023',NULL),
('HD0009', 'BN0009', '21/6/2023',NULL),
('HD00010', 'BN00010','3/1/2023',NULL)
SELECT * FROM HOADON 
GO 
   --TẠO BẢNG CHITIET_HOADON
INSERT INTO CHITIET_HOADON(MAHD, MAL, TENL, SL, THANHTIEN)
VALUES 
('HD0001', 'DV0010',N'Chụp cộng hưởng từ động mạch chi trên có tiêm tương phản (1.5T)', '1',NULL),
('HD0001', 'DV009',N'Chụp cộng hưởng từ động mạch chi trên (1.5T)', '1',NULL),
('HD0001', 'DV0011',N'Định nhóm máu ABO, Rh', '1',NULL),
('HD0001', 'TH0020',N'Thuốc Warfarin 5 S.P.M điều trị ngắn hạn huyết khối tĩnh mạch và nghẽn mạch phổi cấp tính ','14',NULL),

('HD0002', 'DV001',N'Khám Ngoại', '1',NULL),
('HD0002', 'DV002',N'Khám Nội', '1',NULL),
('HD0002', 'DV003',N'Khám Mắt', '1',NULL),
('HD0002', 'DV007',N'Khám Răng hàm mặt', '1',NULL),
('HD0002', 'DV008',N'Khám Tai mũi họng', '1',NULL),
('HD0002', 'DV0011',N'Định nhóm máu ABO, Rh', '1',NULL),

('HD0003', 'DV001',N'Khám Ngoại', '1',NULL),
('HD0003', 'DV0011',N'Định nhóm máu ABO, Rh', '1',NULL),
('HD0003', 'TH0021',N'Viên nén Metformin 850mg Tipharco điều trị đái tháo đường  ','14',NULL),

('HD0004', 'DV001',N'Khám Ngoại', '1',NULL),
('HD0004', 'TH0017',N'Viên ngậm sát trùng Tyrotab Pharmedic điều trị viêm họng, viêm amidan ','14',NULL),

('HD0005', 'DV001',N'Khám Ngoại', '1',NULL),
('HD0005', 'DV0011',N'Định nhóm máu ABO, Rh', '1',NULL),
('HD0005', 'DV009',N'Chụp cộng hưởng từ động mạch chi trên (1.5T)', '1',NULL),
('HD0005', 'TH0022',N'Thuốc Stadovas 5 CAP Stella điều trị tăng huyết áp, đau thắt ngực mạn tính ổn định ','14',NULL),

('HD0006', 'DV0017',N'Nội soi trực tràng ống mềm có sinh thiết', '1',NULL),
('HD0006', 'TH0023',N'Thuốc Berberin 100mg Domesco điều trị nhiễm khuẩn đường ruột, tiêu chảy, kiết lỵ  ','14',NULL),

('HD0007', 'DV0018',N'Nội soi trực tràng ống mềm không sinh thiết', '1',NULL),
('HD0007', 'TH0022',N'Thuốc Stadovas 5 CAP Stella điều trị tăng huyết áp, đau thắt ngực mạn tính ổn định ','14',NULL),

('HD0008', 'DV001',N'Khám Ngoại', '1',NULL),
('HD0008', 'TH0025',N'Viên uống Jex Natural Ecogreen hỗ trợ giảm đau trong thoái hoá khớp, viêm khớp  ','14',NULL),

('HD0009', 'DV004',N'Khám Phụ sản', '1',NULL),
('HD0009', 'DV005',N'Khám Nhi', '1',NULL),
('HD0009', 'DV006',N'Khám Sản Phụ', '1',NULL),


('HD00010', 'DV0014',N'Nội soi thực quản - dạ dày - tá tràng có sinh thiết', '1',NULL),
('HD00010', 'TH0026',N'Hỗn dịch uống Phosphalugel Sanofi giảm độ axit của dạ dày ','1',NULL)
GO
select * from CHITIET_HOADON 
go 
-- TẠO BẢNG DỊCH VỤ 
INSERT INTO DICHVU ( MADV , TENDV , GIA)
VALUES
('DV001',N'Khám Ngoại','200,000'),
('DV002',N'Khám Nội','200,000'),
('DV003',N'Khám Mắt','200,000'),
('DV004',N'Khám Phụ sản','300,000'),
('DV005',N'Khám Nhi','500,000'),
('DV006',N'Khám Phụ sản','300,000'),
('DV007',N'Khám Răng hàm mặt','200,000'),
('DV008',N'Khám Tai mũi họng','200,000'),
('DV009',N'Chụp cộng hưởng từ động mạch chi trên (1.5T)','2,400,000'),
('DV0010',N'Chụp cộng hưởng từ động mạch chi trên có tiêm tương phản (1.5T)','3,600,000'),
('DV0011',N'Định nhóm máu ABO, Rh','173,000'),
('DV0012',N'Siêu âm bụng tổng quát - siêu âm 2D','240,000'),
('DV0013',N'Siêu âm bụng tổng quát - siêu âm 4D','420,000'),
('DV0014',N'Nội soi thực quản - dạ dày - tá tràng có sinh thiết','2,100,000'),
('DV0015',N'Nội soi thực quản - dạ dày - tá tràng không sinh thiết','1,250,000'),
('DV0016',N'Nội soi thực quản - dạ dày - tá tràng qua đường mũi','1,500,000'),
('DV0017',N'Nội soi trực tràng ống mềm có sinh thiết','1,390,000'),
('DV0018',N'Nội soi trực tràng ống mềm không sinh thiết','895,000')
 SELECT*FROM DICHVU
 GO
-- TẠO BẢNG BỆNH ÁN
INSERT INTO BENHAN (MABA , MABN , NGAYNHAPVIEN , NGAYXUATVIEN , KETQUA )
VALUES
('BA101','BN0001','2/9/2023',NULL,N'BỊ BỆNH VAN TIM'),
  ('BA102','BN0002',NULL,NULL,N'BÌNH THƯỜNG '),
  ('BA103','BN0003','11/6/2023',NULL,N'ĐÁI THÁO ĐƯỜNG '),
  ('BA104','BN0004','3/8/2023',NULL,N'UNG THƯ'),
  ('BA105','BN0005','26/9/2023',NULL,N'BỆNH CƠ TIM BỊ GIÃN NỠ'),
  ('BA106','BN0006','1/1/2023',NULL,N'BỆNH ĐƯỜNG RUỘT '),
  ('BA107','BN0007','20/12/2023','21/12/2023',N'VIÊM LOÉT DẠ DÀY '),
  ('BA108','BN0008',NULL,NULL,N'VIÊM KHỚP '),
  ('BA109','BN0009',NULL,NULL,N'BÌNH THƯỜNG'),
  ('BA1010','BN00010','2/1/2023','3/1/2023',N'VIÊM THỰC QUẢN')
  SELECT*FROM BENHAN
  GO 

 --TẠO BẢNG PHÒNG ĐIỀU TRỊ
INSERT INTO PHONGDIEUTRI (MAPDT, LOAIPHONG, MABS, MAKHOA)
VALUES ('PDT001',N'30 CHỖ', 'BS00013','KH0001'), 
 ('PDT002',N'10 CHỖ', 'BS00012','KH0002'),
 ('PDT003',N'5 CHỖ', 'BS00016','KH0003'),
 ('PDT004',N'20 CHỖ', 'BS00017','KH0004'),
 ('PDT005',N'2 CHỖ', 'BS00015','KH0005') 
SELECT * FROM PHONGDIEUTRI
GO
 --TẠO BẢNG PHÒNG KHÁM
INSERT INTO PHONGKHAM (MAPK, MAK, MABS, LOAIPK)
VALUES ('PK01','KH0001', 'BS00013', N'Phòng khám nội khoa 1'),
 ('PK02','KH0001', 'BS00014', N'Phòng khám nội khoa 2'),
 ('PK04','KH0002', 'BS00011', N'Phòng khám ngoại khoa 1'),
 ('PK05','KH0002', 'BS00012', N'Phòng khám ngoại khoa 2'),
 ('PK06','KH0003', 'BS00019', N'Phòng khám Tim mạch 1'),
 ('PK07', 'KH0003','BS00016', N'Phòng khám Tim mạch 2'),
 ('PK08','KH0004', 'BS00017', N'Phòng khám Tiêu hóa'),
 ('PK09','KH0004', 'BS00020', N'Phòng khám Gan - Mật - Tụy'),
 ('PK010','KH0005','BS00015', N'Phòng khám Sản khoa')
SELECT * FROM PHONGKHAM
GO
--TẠO BẢNG BỆNH NHÂN VỚI PHÒNG KHÁM
INSERT INTO BENHNHAN_PHONGKHAM (MABN,MAPK, NGAYKHAM)
VALUES
('BN0001','PK06','3/9/2023'),
('BN0002','PK01','2/4/2023'),
('BN0003','PK01','12/6/2023'),
('BN0004','PK05','4/9/2023'),
('BN0004','PK04','5/10/2023'),
('BN0005','PK06','3/9/2023'),
('BN0006','PK09','3/1/2023'),
('BN0007','PK08','21/12/2023'),
('BN0008','PK02','8/4/2023'),
('BN0008','PK01','1/6/2023'),
('BN0009','PK010','21/6/2023'),
('BN00010','PK08','3/1/2023')
go
SELECT * FROM BENHNHAN_PHONGKHAM
GO


-- TẠO BẢNG BỆNH NHÂN VỚI PHÒNG ĐIỀU TRỊ 
INSERT INTO BENHNHAN_PHONGDIEUTRI(MABN, PHGDT, NGAYNHAPVIEN, NGAYXUATVIEN)
VALUES 
('BN0001', 'PDT003', '2/9/2023', null),
('BN0003', 'PDT001', '11/6/2023', null),
('BN0004', 'PDT002', '3/8/2023', null),
('BN0005', 'PDT003', '26/9/2023', null),
('BN0006', 'PDT004', '1/1/2023', null)
GO
SELECT * FROM BENHNHAN_PHONGDIEUTRI
go
-- TẠO BẢNG MUA_THUOC
INSERT INTO MUA_THUOC(MATHUOC, MABN, SL,MABS)
VALUES ('TH0020','BN0001','14','BS00019'),
 ('TH0021','BN0003','14','BS00012'),
 ('TH0017','BN0004','14','BS00014'),
 ('TH0022','BN0005','14','BS00016'),
 ('TH0023','BN0006','14','BS00017'),
 ('TH0022','BN0007','1','BS00017'),
 ('TH0025','BN0008','14','BS00013'),
 ('TH0026','BN00010','14','BS00013')
SELECT * FROM MUA_THUOC
GO

-- TẠO BẢNG SUDUNG_DICHVU
INSERT INTO SUDUNG_DICHVU(MADV, MABN,TGIAN, SL)
VALUES ('DV0010','BN0001', '3/9/2023','1'),
  ('DV009','BN0001', '3/9/2023', '1'),
  ('DV0011','BN0001', '3/9/2023', '1'),
  ('DV001','BN0002', '2/4/2023', '1'),
  ('DV002','BN0002', '2/4/2023', '1'),
  ('DV003','BN0002', '2/4/2023', '1'),
  ('DV007','BN0002', '2/4/2023', '1'),
  ('DV008','BN0002', '2/4/2023', '1'),
  ('DV0011','BN0002', '2/4/2023', '1'),
  ('DV001','BN0003', '12/6/2023', '1'),
  ('DV0011','BN0003', '12/6/2023', '1'),
  ('DV001','BN0004', '4/9/2023', '1'),
  ('DV001','BN0005', '3/9/2023', '1'),
  ('DV0011','BN0005', '3/9/2023', '1'),
  ('DV009','BN0005', '3/9/2023', '1'),
  ('DV0017','BN0006', '3/1/2023', '1'),
  ('DV0018','BN0007', '21/12/2023', '1'),
  ('DV001','BN0008', '8/4/2023', '1'),
  ('DV004','BN0009', '21/6/2023', '1'),
  ('DV005','BN0009', '21/6/2023', '1'),
  ('DV006','BN0009', '21/6/2023', '1'),
  ('DV0014','BN00010', '3/1/2023', '1')
SELECT * FROM SUDUNG_DICHVU
GO
