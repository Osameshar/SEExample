using System;
using SQLite.Net;

namespace TestAppPCL
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}