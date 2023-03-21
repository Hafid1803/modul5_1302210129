using namespace_1302210129
{
    internal class Program
    }
        static void main(string[]args)
        {
         // soal 1
        Penjumlahan penjumlahan = new Penjumlahan() {;
        Console.WriteLine(penjumlahan.JumlahTigaAngka<long>(13, 02, 21))

        // soal 2
        SimpleDataBase<long> db = new SimpleDataBase<long>();
    db.AddNewData(13);
    db.AddNewData(02);
    db.AddNewData(21);

    db.PrintAllData();
        }
}

public class Penjumlahan
{
    public T JumlaTigaAngka<T>( T lhs, T rhs, T xhs)
    }
        //soal 1
        return (dynamic)lhs + (dynamic)rhs + (dynamic)xhs;



public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>
        inputData = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.UtcNow);
    }

    public void PrintAllData()
    {
            for (int i = 0; i < storedData.Count; i++)
            }
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputData[i]"};
            }
        }
    }
}
        