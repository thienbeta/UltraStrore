B1: File Cần tham khảo nằm trong app/(tabs)/Home.jsx và app/(tabs)/Detail.jsx
B2:  dòng : 
const response = await fetch("http://192.168.1.11:5261/api/SanPham/ListSanPham",
Hãy sửa dòng này thành địa chỉ api đúng của dự án chạy bằng visual tím. Ví dụ bên a là 
localhost:5261/api/SanPham/ListSanPham> 
Tương tự cho trang Detail cũng sẽ cần sửa dòng này
B3: Câu lệnh để chạy là npx expo start –clear
B4:  Trên PC thì hình ảnh Logo sẽ bị lỗi. có thể bỏ qua trang signin và đi thằng tới trang home bằng cách gõ localhost: … / Home
