# tranxuanthinh-24810320263
Câu 1: Trình bày sự khác nhau giữa Value Types (Kiểu giá trị) và Reference Types (Kiểu tham chiếu) trong C# về cơ chế lưu trữ vùng nhớ (Stack vs Heap).
Value Types (kiểu giá trị):
- Biến chứa trực tiếp giá trị của dữ liệu.
- Thường được lưu trên Stack khi biến là biến cục bộ.
- Khi gán một biến Value Type cho biến khác, giá trị được sao chép sang biến mới.
- Ví dụ: int, float, double, bool, struct, enum.
Ví dụ:
int a = 10;
int b = a;
b = 20;
Sau khi b = 20 thì a vẫn bằng 10 vì a và b chứa hai bản sao giá trị độc lập.
Reference Types (kiểu tham chiếu):
- Biến chứa tham chiếu đến đối tượng được lưu trên Heap.
- Khi gán một biến Reference Type cho biến khác, hai biến có thể cùng tham chiếu đến một đối tượng.
- Ví dụ: class, object, string, array, interface.
Ví dụ:
class Student
{
    public string Name;
}
Student s1 = new Student();
Student s2 = s1;
s2.Name = "Thinh";
Lúc này s1.Name cũng là "Thinh" vì s1 và s2 cùng tham chiếu đến một đối tượng trên Heap.
Tóm lại:
- Value Type: chứa trực tiếp giá trị, thường gặp với Stack đối với biến cục bộ, khi gán thì sao chép giá trị.
- Reference Type: chứa tham chiếu đến đối tượng trên Heap, khi gán thì sao chép tham chiếu.

Lưu ý: Nói “Value Type luôn ở Stack, Reference Type luôn ở Heap” là cách giải thích đơn giản; trong .NET thực tế vị trí vật lý còn phụ thuộc vào ngữ cảnh.
Câu 2: Tính năng Init-only Properties (init) trong C# 9/10 khác gì so với thuộc tính có set thông thường? Nêu trường hợp sử dụng thực tế.
set cho phép thuộc tính được thay đổi bất cứ lúc nào sau khi đối tượng được tạo.
Ví dụ:
class Student
{
    public string Name { get; set; }
}
Student sv = new Student();
sv.Name = "Thinh";
sv.Name = "Nam";   // Có thể thay đổi
Trong khi đó, init cho phép thiết lập giá trị khi khởi tạo đối tượng, nhưng sau khi quá trình khởi tạo hoàn tất thì không thể gán lại bằng cách thông thường.
Ví dụ:
class Student
{
    public string Name { get; init; }
}
Student sv = new Student
{
    Name = "Thinh"
};
// sv.Name = "Nam"; // Lỗi
Trường hợp sử dụng thực tế:
init phù hợp với các đối tượng mà một số thông tin cần được xác định ngay khi tạo và không muốn thay đổi sau đó.
Ví dụ:
class Product
{
    public int Id { get; init; }
    public string Name { get; init; }
    public double Price { get; set; }
}
Khi tạo sản phẩm:
Product p = new Product
{
    Id = 101,
    Name = "Laptop",
    Price = 15000000
};
Sau đó Id và Name không nên thay đổi, còn Price vẫn có thể thay đổi.
Tóm lại:
- set: có thể gán lại sau khi tạo đối tượng.
- init: chỉ cho phép thiết lập trong quá trình khởi tạo.
Câu 3: Phân biệt sự khác nhau giữa phương thức virtual ở lớp cha và phương thức override ở lớp con khi triển khai tính Đa hình (Polymorphism).
virtual được khai báo ở lớp cha để cho phép lớp con ghi đè (override) phương thức đó.
Ví dụ:
class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal sound");
    }
}
override được sử dụng ở lớp con để cung cấp cách triển khai mới cho phương thức virtual của lớp cha.
Ví dụ:
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Gau gau");
    }
}
Khi sử dụng:
Animal a = new Dog();
a.Sound();
Kết quả:
Gau gau
Đây chính là đa hình (Polymorphism): biến có kiểu Animal nhưng đối tượng thực tế là Dog, vì vậy phương thức Sound() của Dog được thực hiện.
Phân biệt:
- virtual: khai báo ở lớp cha, cho phép phương thức được ghi đè và cung cấp triển khai mặc định.
- override: khai báo ở lớp con, thực hiện ghi đè và cung cấp triển khai mới.
- virtual là cơ sở để tạo đa hình; override thể hiện việc triển khai đa hình ở lớp con.
Câu 4: Tại sao một thành phần được khai báo là static trong Lớp (Class) lại không thể truy xuất thông qua một thể hiện (Object Instance) được tạo bằng toán tử new?
Thành phần static thuộc về Class, không thuộc về từng đối tượng được tạo bằng new.
Ví dụ:
class Student
{
    public static string School = "EPU";
}
Ta truy cập trực tiếp thông qua tên lớp:
Console.WriteLine(Student.School);
Không truy cập thành viên static thông qua một object instance:
Student sv = new Student();
sv.School;   // Không được phép theo cú pháp truy cập thành viên static
Lý do:
Khi tạo nhiều đối tượng:
Student sv1 = new Student();
Student sv2 = new Student();
Student sv3 = new Student();
thì School vẫn chỉ là một thành viên dùng chung của lớp Student, chứ không phải mỗi object có một School riêng.

static được tạo và quản lý ở cấp độ lớp, còn các thành viên thông thường thuộc về Instance/Object.
Vì vậy:
Student.School  // Đúng
sv1.School      // Sai
Tóm lại, static thuộc về Class và không gắn với một object cụ thể.
