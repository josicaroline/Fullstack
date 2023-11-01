import { CardComponent } from "../../components/card/CardComponent"
import * as PageStyled from "../Pages.style"

export const HomePage = () => {
  const data = {
    title: 'Joseane',
    description: 'Pós doc',
    email: 'josi@outlook.com'
  }

  return(
    <PageStyled.Container data-testid="home-testid">
      <CardComponent
        testid='card-josi'
        description={data.description}
        title={data.title}
        email={data.email}
      />
    </PageStyled.Container>
  )
}