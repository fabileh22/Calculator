//FL 04.05.23

var builder = WebApplication.CreateBuilder(args);

//Sets up a service for the controllers
builder.Services.AddControllers();

//Adds an endpoint of communication to assure the SwaggerUI
builder.Services.AddEndpointsApiExplorer();

//Adds the necessary Swagger services for the application to run
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Assures that we are running the app from the Development Environment
//Different environments can be added later
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Forwards the URL to multiple locations if inital location is unavailable
app.UseHttpsRedirection();

//Authenticates User to access "secure" recources
app.UseAuthorization();

//Maps data to the web object in order to run the controllers
app.MapControllers();

app.Run();

