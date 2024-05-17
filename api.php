<?php
// Database connection details
$servername = "localhost";
$username = "root";
$password = "alepse123!";
$dbname = "mydatabase";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// GET request to fetch data from two tables
if ($_SERVER['REQUEST_METHOD'] === 'GET') {
    $sql = "SELECT p.product_id, p.product_name, p.price, p.description, c.category_name 
            FROM products p 
            JOIN categories c ON p.category_id = c.category_id";
    $result = $conn->query($sql);

    $data = array();
    while ($row = $result->fetch_assoc()) {
        $data[] = $row;
    }

    echo json_encode($data);
}

// POST request to add a new product
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    // Validate and sanitize inputs
    $product_name = filter_input(INPUT_POST, 'product_name', FILTER_SANITIZE_STRING);
    $category_id = filter_input(INPUT_POST, 'category_id', FILTER_VALIDATE_INT);
    $price = filter_input(INPUT_POST, 'price', FILTER_VALIDATE_FLOAT);
    $description = filter_input(INPUT_POST, 'description', FILTER_SANITIZE_STRING);

    if ($product_name && $category_id && $price !== false && $description) {
        // Use prepared statements to prevent SQL injection
        $stmt = $conn->prepare("INSERT INTO products (product_name, category_id, price, description) VALUES (?, ?, ?, ?)");
        $stmt->bind_param("sids", $product_name, $category_id, $price, $description);

        if ($stmt->execute()) {
            echo json_encode(array('message' => 'Product added successfully'));
        } else {
            echo json_encode(array('error' => 'Error adding product: ' . $stmt->error));
        }

        $stmt->close();
    } else {
        echo json_encode(array('error' => 'Invalid input'));
    }
}

$conn->close();
?>
