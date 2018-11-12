<?php /** @var \MyMoney\DTO\UserDTO|null $data */?>

<h1>Login User</h1>
<?php foreach ($errors as $error): ?>
    <p style="color: red"><?=$error?></p>
<?php endforeach;
if(isset($_SESSION['success'])):?>
    <p style="color: green">Congratulations, <?=$_SESSION['success']?>. Login in our platform to manage your finances.</p>
<?php endif;?>

<form method="post">
    <div>
        <label for="username">Username: </label>
        <input type="text" name="username" value="<?=$data != null ? $data->getUsername() : ""?>">
    </div>
    <div>
        <label for="password">Password: </label>
        <input type="password" name="password" value="<?=$data != null ? $data->getPassword() : ""?>">
    </div>
    <div>
        <input type="submit" name="login" value="Login Now!">
    </div>
</form>