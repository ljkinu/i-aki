<form action="procesar_formulario.php" method="POST">
  <!-- ... rest of the form fields ... -->
  <input type="submit" value="Enviar">
</form>


<?php
// Obtener los datos enviados por el formulario
$nombre = $_POST['nombre'];
$email = $_POST['email'];
$mensaje = $_POST['mensaje'];

// Realizar la conexión a la base de datos
$conexion = mysqli_connect('localhost', 'usuario', 'contraseña', 'nombre_base_datos');

// Verificar si la conexión fue exitosa
if ($conexion) {
  // Insertar los datos en la tabla correspondiente
  $query = "INSERT INTO tabla_datos (nombre, email, mensaje) VALUES ('$nombre', '$email', '$mensaje')";
  mysqli_query($conexion, $query);
  
  // Cerrar la conexión
  mysqli_close($conexion);
  
  // Redireccionar al usuario a una página de éxito
  header('Location: exito.html');
  exit;
} else {
  // Mostrar un mensaje de error si la conexión falla
  echo 'Error al conectar con la base de datos';
}
?>
