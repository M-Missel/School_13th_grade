<html>
	<head>
		<title>Demo</title>
	</head>
	
	<body>
		<h1>PHP-Demo</h1>
		
		<?php
			echo "<p> <strong>Hallo</strong> TGI </p>";
			
			$zahlX = 12;

			$zahlX = 12 * 12;
			
			echo "<p> Hallo TGI </p>";
			echo "<p> $zahlX </p>";
			
			for($i = 1; $i < 11; $i++){
				$zahlAusgabe = $i * $i;
				echo "<p> $i * $i = $zahlAusgabe";
			}
		?>
	</body>
</html>