<html>
	<head>
		<title>Demo</title>
		<link rel="stylesheet" href="02c_quadrat.css" type="text/css"/>
	</head>
	
	<body>
		<h1>Schuelerliste</h1>
		
		<?php
			$pdo = new PDO("mysql:host=localhost;dbname=tgi13",
							"username",
							"password");
							
			$sql = 'SELECT vorname, name FROM schueler';
			$stm = $pdo->query($sql);
			
			/* Aufgabe 1
 			while($row = $stm->fetchObject()){
				echo $row->vorname . " ";
				echo $row->name . "<br>";
			}
			
			$stm = null;
			$pdo = null;
			*/
			
			
			if($stm->rowCount() != 0){
				echo "<table>\n";
				while($row = $stm->fetchObject()){
					echo "	<tr>\n".
						 "	  <td> $row->vorname </td>\n".
						 "	  <td> $row->name </td>\n".
						 "	</tr>\n";
				}
				echo "</table>";				
			}else{
				echo "<p>keine Datensaetze gefunden</p>";
			}
			
			$stm = null;
			$pdo = null;
		?>
	</body>
</html>