SensorLuminosity sensor1 = new SensorLuminosity();
SensorTemperature sensor2 = new SensorTemperature();
SensorHumidity sensor3 = new SensorHumidity();

var alexa = new Alexa();

Random random = new Random();

sensor1.SetLuminosity(random.Next(1, 101));
Console.WriteLine("The luminosity is: " + sensor1.GetLuminosity());
if (!sensor1.ValidLuminosity(sensor1.GetLuminosity())) alexa.Register(sensor1);

sensor2.SetTemperature(random.Next(1, 101));
Console.WriteLine("The temperature is: " + sensor2.GetTemperature());
if (!sensor2.ValidTemperature(sensor2.GetTemperature())) alexa.Register(sensor2);

sensor3.SetHumidity(random.Next(1, 101));
Console.WriteLine("The humidity is: " + sensor3.GetHumidity());
if (!sensor3.ValidHumidity(sensor3.GetHumidity())) alexa.Register(sensor3);

alexa.ToWarn();