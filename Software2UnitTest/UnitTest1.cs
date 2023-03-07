using MySql.Data.MySqlClient;
using NUnit.Framework;
using Software2;
using System;
using System.Data;

namespace Software2UnitTest
{
    public class Tests
    {
        Appointment appointment1;
        Appointment appointment2;
        [SetUp]
        public void Setup()
        {

        }

        public static void DeleteAppointment()
        {
            string sql = "DELETE FROM appointment WHERE car ='TEST'";
            MySqlConnection conn = Software2.Database.SQL.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                
            }
            conn.Close();
        }
        [Test]
        public void OverlappingAppointments()
        {
            //ARRANGE
            appointment1 = new Appointment("1", "1", "TEST", "Water Pump", new DateTime(1968, 02, 24, 15, 30, 50), new DateTime(1968, 02, 24, 15, 30, 50));
            appointment2 = new Appointment("2", "1", "TEST", "Water Pump", new DateTime(1968, 02, 24, 15, 30, 50), new DateTime(1968, 02, 24, 15, 30, 50));

            //ACT
            DbAppointment.AddAppointment(appointment2);
            bool overlap = DbAppointment.Overlap(appointment1.start, appointment1.end);
            DeleteAppointment();
            //ASSERT

            Assert.That(overlap, Is.True);
        }

        [Test]
        public void NonOverlappingAppointments()
        {
            //ARRANGE
            appointment1 = new Appointment("1", "1", "TEST", "Water Pump", new DateTime(1949, 02, 24, 15, 30, 50), new DateTime(1949, 02, 24, 15, 30, 50));
            appointment2 = new Appointment("2", "1", "TEST", "Water Pump", new DateTime(1949, 02, 26, 15, 30, 50), new DateTime(1949, 02, 26, 15, 30, 50));

            //ACT
            DbAppointment.AddAppointment(appointment2);
            bool overlap = DbAppointment.Overlap(appointment1.start, appointment1.end);
            DeleteAppointment();
            //ASSERT

            Assert.That(overlap, Is.False);
        }

        [Test]
        public void NonOverlappingAppointmentsAdjacent()
        {
            //ARRANGE
            appointment1 = new Appointment("1", "1", "TEST", "Water Pump", new DateTime(1996, 02, 24, 15, 30, 50), new DateTime(1996, 02, 24, 15, 30, 50));
            appointment2 = new Appointment("2", "1", "TEST", "Water Pump", new DateTime(1996, 02, 24, 15, 31, 50), new DateTime(1996, 02, 24, 15, 31, 50));

            //ACT
            DbAppointment.AddAppointment(appointment2);
            bool overlap = DbAppointment.Overlap(appointment1.start, appointment1.end);
            DeleteAppointment();
            //ASSERT

            Assert.That(overlap, Is.False);
        }

    }
}