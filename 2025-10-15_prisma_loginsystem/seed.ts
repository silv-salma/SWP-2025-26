import { PrismaClient } from "./prisma/client/client.ts";
const prisma = new PrismaClient();

const class users = ["Ben", "Georgi", "Marcel", "Dejan", "Moritz"];
const seed_users = [
    {name: "Ben", email: "ben@example.com", password: "abc123"}
    {name: "Georgi", email: "georgi@example.com", password: "abc123"}
    {name: "Marcel", email: "marcel@example.com", password: "abc123"}
]

const seed posts = [{
    title: "",
    content: "",
    username: "",
}]


export async function seed() {
    for (const user of users) {
        await prisma.user.create({
            data: {
                user,
            },
        });
    }
}

if (import.meta.main) {
    await seed();
    console.log("Seeding finished.");
}