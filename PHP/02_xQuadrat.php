<html>
	<head>
		<title>Demo</title>
		<link rel="stylesheet" href="02c_quadrat.css" type="text/css"/>
	</head>
	
	<body>
		<h1>PHP-Demo Aufgabe 2</h1>
		
		<?php
			//Aufgabe a
			$zahlX = 12;

			$zahlX = 12 * 12;
			
			echo "<p> Hallo TGI </p>";
			echo "<p> $zahlX </p>";
			//Aufgabe a
			
			//Aufgabe b
			for($i = 1; $i < 11; $i++){
				$zahlAusgabe = $i * $i;
				echo "<p> $i * $i = $zahlAusgabe";
			}
			//Aufgabe b
			
			//Aufgabe c
			echo "<table>";
			for($i = 1; $i < 11; $i++){
				$zahlAusgabe = $i * $i;
				echo "<tr> <td> $i * $i </td> <td>=</td> <td class='zahlright'>$zahlAusgabe</td> </tr>";
			}
			echo "</table>";
			//Aufgabe c
			
		?>
	</body>
</html>