<?php /** @var \App\DTO\UserDTO $data */?>

<h1>REGISTER NEW USER</h1>
<?php foreach ($errors as $error): ?>
    <p style="color: red"><?=$error?></p>
<?php endforeach;?>
<form method="post">
    <div>
        <label for="username">Username:</label>
        <input type="text" name="username" value="<?=$data != null ? $data->getUsername() : ""?>">
    </div>
    <div>
        <label for="password">Password:</label>
        <input type="password" name="password" value="<?=$data != null ? $data->getPassword() : ""?>">
    </div>
    <div>
        <label for="confirm_password">Confirm Password:</label>
        <input type="password" name="confirm_password">
    </div>
    <div>
        <label for="full_name">Full Name:</label>
        <input type="text" name="full_name" value="<?=$data != null ? $data->getFullName() : ""?>">
    </div>
    <div>
        <label for="bornOn">Born On:</label>
        <input type="date" name="born_on" value="<?=$data != null ? $data->getBornOn() : ""?>">
    </div>
    <div>
        <input type="submit" name="register" value="Register!">
    </div>
</form>
