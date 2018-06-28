import java.util.Scanner;

public class p16URLParser {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String url = scanner.nextLine();
        String protocol ="";
        String server = "";
        String resource = "";

        if(url.contains("://")){
            String[] urlInfo = url.split("://");
            protocol = urlInfo[0];

            if(urlInfo[1].contains("/")){
                String[] serverInfo = urlInfo[1].split("/");
                server = serverInfo[0];
                resource = urlInfo[1].substring(server.length() + 1);
            } else{
                server = urlInfo[1];
            }
        } else if(url.contains("/")){
            String[] serverInfo = url.split("/");
            server = serverInfo[0];
            resource = url.substring(server.length() + 1);
        } else{
            server = url;
        }

        System.out.printf("[protocol] = \"%s\"%n", protocol);
        System.out.printf("[server] = \"%s\"%n", server);
        System.out.printf("[resource] = \"%s\"", resource);
    }

}

