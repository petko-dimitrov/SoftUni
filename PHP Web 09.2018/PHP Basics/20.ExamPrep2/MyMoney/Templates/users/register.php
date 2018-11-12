<?php /** @var \MyMoney\DTO\UserDTO|null $data */?>

<h1>Register New User</h1>
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
        <label for="fullName">Full Name:</label>
        <input type="text" name="fullName" value="<?=$data != null ? $data->getFullName() : ""?>">
    </div>
    <div>
        <label for="bornOn">Born On:</label>
        <input type="date" name="bornOn" value="<?=$data != null ? $data->getBornOn() : ""?>">
    </div>
    <div>
        <input type="submit" name="register" value="Register!">
    </div>
</form>